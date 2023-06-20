using OracleMixedTool.Models;

namespace OracleMixedTool.Services
{
    public class DataHandler
    {
        private static readonly object lockData = new();
        private static readonly object lockProxy = new();
        private static readonly object lockSuccess = new();
        private static readonly object lockFailed = new();
        private static readonly object lockError = new();
        private static readonly object lockLogs = new();
        private static readonly object lockInfo = new();
        private static readonly object lockSSH = new();
        private static readonly object lockPassword = new();

        public static string ReadPasswordFromFile()
        {
            lock (lockPassword)
            {
                try
                {
                    var filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "newpassword.dat");
                    using var reader = new StreamReader(filename, false);
                    var value = reader.ReadToEnd();
                    reader.Close();
                    return value;
                }
                catch { return string.Empty; }
            }
        }

        public static void SavePasswordToFile(string newPassword)
        {
            lock (lockPassword)
            {
                try
                {
                    var filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "newpassword.dat");
                    using var writer = new StreamWriter(filename, false);
                    writer.Write(newPassword);
                    writer.Flush();
                    writer.Close();
                }
                catch { }
            }
        }

        public static string ReadSSHFromFile()
        {
            lock (lockSSH)
            {
                try
                {
                    var filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ssh.dat");
                    using var reader = new StreamReader(filename, false);
                    var value = reader.ReadToEnd();
                    reader.Close();
                    return value;
                }
                catch { return string.Empty; }
            }
        }

        public static void SaveSSHToFile(string ssh)
        {
            lock (lockSSH)
            {
                try
                {
                    var filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ssh.dat");
                    using var writer = new StreamWriter(filename, false);
                    writer.Write(ssh);
                    writer.Flush();
                    writer.Close();
                }
                catch { }
            }
        }

        public static void WriteLastInfo(int scanned, string fileName)
        {
            lock (lockInfo)
            {
                var basePath = AppDomain.CurrentDomain.BaseDirectory;
                try
                {
                    var folder = Path.Combine(basePath, "last");
                    if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
                    var filePath = Path.Combine(folder, $"{fileName}_{scanned}_{DateTime.Now:HHmmss}_{DateTime.Now:ddMMyyyy}");
                    using var stream = File.Create(filePath);
                    stream.Close();
                }
                catch { }
            }
        }

        //email:pass:delete:ip1;ip2:reboot:ip1;ip2:create:VPS-1:1
        public static Queue<Account> ReadDataFile(string path)
        {
            lock (lockData)
            {
                var data = new Queue<Account>();
                try
                {
                    using var reader = new StreamReader(path);
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        try
                        {
                            var info = line.Split(":");
                            var acc = new Account
                            {
                                Email = info[0],
                                Password = info[1],
                                CurrentPassword = info[1]
                            };
                            for (var index = 2; index < info.Length; index++)
                            {
                                switch (info[index].ToLower())
                                {
                                    case "delete":
                                        if (string.IsNullOrWhiteSpace(info[index + 1])) continue;
                                        var tobeDelete = info[index + 1].Split(";").Select(ip => ip.Trim())
                                            .Distinct().ToList();
                                        tobeDelete.Remove("");
                                        acc.ToBeDeleteInstances.AddRange(tobeDelete);
                                        break;
                                    case "reboot":
                                        if (string.IsNullOrWhiteSpace(info[index + 1])) continue;
                                        var tobeReboot = info[index + 1].Split(";").Select(ip => ip.Trim())
                                            .Distinct().ToList();
                                        tobeReboot.Remove("");
                                        acc.ToBeRebootInstances.AddRange(info[index + 1].Split(";"));
                                        break;
                                    case "create":
                                        if (string.IsNullOrWhiteSpace(info[index + 1])) continue;
                                        acc.ToBeCreateInstance = info[index + 1];
                                        acc.Image = Enum.Parse<ImgType>(info[index + 2]);
                                        break;
                                    default: break;
                                }
                            }
                            acc.OriginalData = line;
                            data.Enqueue(acc);
                        }
                        catch (Exception ex)
                        {
                            WriteLog("[ReadDataFile]", new Exception($"{line}: {ex.Message}."));
                        }
                        line = reader.ReadLine();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    WriteLog("[ReadDataFile]", ex);
                }
                return data;
            }
        }

        public static List<string> ReadProxyFile(string path)
        {
            lock (lockProxy)
            {
                var data = new List<string>();
                try
                {
                    using var reader = new StreamReader(path);
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var detail = line.Split(":");
                        if (detail.Length != 2 && detail.Length != 4) continue;
                        else data.Add(line);

                        line = reader.ReadLine();
                    }
                }
                catch (Exception ex)
                {
                    WriteLog("[ReadProxyFile]", ex);
                }
                return data;
            }
        }

        public static void WriteSuccessData(Account acc)
        {
            lock (lockSuccess)
            {
                try
                {
                    var basePath = AppDomain.CurrentDomain.BaseDirectory;
                    var directoryPath = Path.Combine(basePath, "output");
                    var subDirectoryPath = Path.Combine(basePath, "output", "success");

                    var fileName = $"{DateTime.Now:ddMMyyyy}success.txt";
                    if (!Directory.Exists(directoryPath)) Directory.CreateDirectory(directoryPath);
                    if (!Directory.Exists(subDirectoryPath)) Directory.CreateDirectory(subDirectoryPath);

                    using var writer = new StreamWriter(Path.Combine(subDirectoryPath, fileName), true);

                    writer.WriteLine("Email: " + acc.Email);
                    writer.WriteLine("Password: " + acc.CurrentPassword);
                    writer.WriteLine("New Password: " + acc.NewPassword);

                    writer.WriteLine("To Be Created: " + acc.ToBeCreateInstance);
                    writer.WriteLine("To Be Deleted: " + string.Join(";", acc.ToBeDeleteInstances));
                    writer.WriteLine("To Be Rebooted: " + string.Join(";", acc.ToBeRebootInstances));

                    writer.WriteLine("Deleted: " + string.Join(";", acc.ToBeDeleteInstances));
                    writer.WriteLine("Rebooted: " + string.Join(";", acc.ToBeRebootInstances));
                    writer.WriteLine("Instances:");
                    foreach (var instance in acc.CurrentInstances)
                    {
                        writer.WriteLine(instance);
                    }
                    writer.WriteLine("===========================================");
                    writer.Flush();
                    writer.Close();
                }
                catch (Exception ex)
                {
                    WriteLog("[WriteSuccessData]", ex);
                }
            }
        }

        private static void WriteErrorData(Account acc, string originalFilename, string reason)
        {
            lock (lockError)
            {
                try
                {
                    var basePath = AppDomain.CurrentDomain.BaseDirectory;
                    var directoryPath = Path.Combine(basePath, "output");
                    var subDirectoryPath = Path.Combine(basePath, "output", "error");

                    var fileName = $"{DateTime.Now:ddMMyyyy}error.txt";
                    if (!Directory.Exists(directoryPath)) Directory.CreateDirectory(directoryPath);
                    if (!Directory.Exists(subDirectoryPath)) Directory.CreateDirectory(subDirectoryPath);

                    using var writer = new StreamWriter(Path.Combine(subDirectoryPath, fileName), true);

                    writer.WriteLine("Email: " + acc.Email);
                    writer.WriteLine("Password: " + acc.CurrentPassword);
                    writer.WriteLine("New Password: " + acc.NewPassword);

                    writer.WriteLine("To Be Created: " + acc.ToBeCreateInstance);
                    writer.WriteLine("To Be Deleted: " + string.Join(";", acc.ToBeDeleteInstances));
                    writer.WriteLine("To Be Rebooted: " + string.Join(";", acc.ToBeRebootInstances));

                    writer.WriteLine("Deleted: " + string.Join(";", acc.ToBeDeleteInstances));
                    writer.WriteLine("Rebooted: " + string.Join(";", acc.ToBeRebootInstances));
                    writer.WriteLine("Instances:");
                    foreach (var instance in acc.CurrentInstances)
                    {
                        writer.WriteLine(instance);
                    }

                    writer.WriteLine("Errors:");
                    writer.WriteLine(reason);
                    foreach (var error in acc.Errors)
                    {
                        writer.WriteLine(error);
                    }
                    writer.WriteLine("===========================================");

                    writer.Flush();
                    writer.Close();
                }
                catch (Exception ex)
                {
                    WriteLog("[WriteErrorData]", ex);
                }
            }
        }

        public static void WriteFailedData(Account acc, string originalFilename, string reason)
        {
            lock (lockFailed)
            {
                try
                {
                    var basePath = AppDomain.CurrentDomain.BaseDirectory;
                    var directoryPath = Path.Combine(basePath, "output");
                    var subDirectoryPath = Path.Combine(basePath, "output", "failed");

                    var fileName = $"{DateTime.Now:ddMMyyyy}failed-{originalFilename}.txt";
                    if (!Directory.Exists(directoryPath)) Directory.CreateDirectory(directoryPath);
                    if (!Directory.Exists(subDirectoryPath)) Directory.CreateDirectory(subDirectoryPath);

                    using var writer = new StreamWriter(Path.Combine(subDirectoryPath, fileName), true);
                    writer.WriteLine(acc.OriginalData);
                    writer.Flush();
                    writer.Close();
                }
                catch (Exception ex)
                {
                    WriteLog("[WriteFailedData]", ex);
                }
            }
            WriteErrorData(acc, originalFilename, reason);
        }

        public static void WriteLog(string prefix, Exception ex)
        {
            lock (lockLogs)
            {
                WriteSimpleLog(prefix, ex.Message);
                WriteDetailsLog(prefix, ex.ToString());
            }
        }

        private static void WriteSimpleLog(string prefix, string data)
        {
            try
            {
                var basePath = AppDomain.CurrentDomain.BaseDirectory;
                var directoryPath = Path.Combine(basePath, "logs");
                var fileName = $"{DateTime.Now:ddMMyyyy}simplelog.txt";
                if (!Directory.Exists(directoryPath)) Directory.CreateDirectory(directoryPath);

                using var writer = new StreamWriter(Path.Combine(directoryPath, fileName), true);
                writer.WriteLine($"{DateTime.Now:HH:mm:ss} {prefix} {data}");
                writer.Flush();
                writer.Close();
            }
            catch { }
        }

        private static void WriteDetailsLog(string prefix, string data)
        {
            try
            {
                var basePath = AppDomain.CurrentDomain.BaseDirectory;
                var directoryPath = Path.Combine(basePath, "logs");
                var fileName = $"{DateTime.Now:ddMMyyyy}log.txt";
                if (!Directory.Exists(directoryPath)) Directory.CreateDirectory(directoryPath);

                using var writer = new StreamWriter(Path.Combine(directoryPath, fileName), true);
                writer.WriteLine($"{DateTime.Now:HH:mm:ss} {prefix} {data}");
                writer.Flush();
                writer.Close();
            }
            catch { }
        }
    }
}

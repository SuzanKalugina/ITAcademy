var path = string.Empty;

while (true)
{
    Console.Write($"{path}: ");

    var command = Console.ReadLine();

    if (command.StartsWith("cd"))
    {
        path = command.Split(' ')[1];
    }

    if (command == "ls")
    {
        var files = Directory.GetFiles(path);
        var directories = Directory.GetDirectories(path);

        Console.WriteLine("    Files: " + string.Join(' ', files.Select(x => Path.GetFileName(x))));
        Console.WriteLine("    Directories: " + string.Join(' ', directories.Select(x => x.Remove(0, path.Length))));
    }

    if (command.StartsWith("rm"))      // -d Удаление файла/папки
    {
        var param = command.Split(' ')[1];
        var name = command.Split(' ')[2];

        var fullPath = Path.Join(path, name);
        switch (param)
        {
            case "-d" when Directory.Exists(fullPath):
                Directory.Delete(fullPath, true);
                Console.WriteLine("Directory deleted");
                break;
            case "-f":
                File.Delete(fullPath);
                Console.WriteLine("File deleted");
                break;
            default:
                Console.WriteLine("Invalid param");
                break;
        }
    }

    if (command.StartsWith("mv")) //переименование/перемещение папки
    {
        var param = command.Split(' ')[1];
        var oldName = command.Split(' ')[2];
        var newName = command.Split(' ')[3];

        var fullOldPath = Path.Join(path, oldName);
        var fullNewPath = Path.Join(path, newName, oldName);

        if (param == "-d")
        {
            if (Directory.Exists(fullOldPath) && !Directory.Exists(fullNewPath))
            {
                Directory.Move(fullOldPath, fullNewPath);
                Console.WriteLine("Created new directory");
            }
        }
        else if (param == "-f")
        {
            if (File.Exists(fullOldPath) && !File.Exists(fullNewPath))
            {
                File.Move(fullOldPath, fullNewPath);
                Console.WriteLine("Created new file");
            }
        }
        else
        {
            Console.WriteLine("Invalid param");
        }
    }

    if (command.StartsWith("cp")) //копирование файла
    {
            var param = command.Split(' ')[1];
            var oldName = command.Split(' ')[2];
            var newName = command.Split(' ')[3];

            var fullOldPath = Path.Join(path, oldName);
            var fullNewPath = Path.Join(path, newName);

            if (param == "-d")
            {
                if (Directory.Exists(fullOldPath) && !Directory.Exists(fullNewPath))
                {
                    CopyDirectory(fullOldPath, fullNewPath, true);
                 //   Directory.Copy(fullOldPath, fullNewPath); ///!!!!!!!!!!!!!!
                Console.WriteLine("directory copied ");
                }
            }
            else if (param == "-f")
            {
                if (File.Exists(fullOldPath) && !File.Exists(fullNewPath))
                {
                    File.Copy(fullOldPath, fullNewPath);
                    Console.WriteLine("file copied ");
                }
            } 
            else
            {
                 Console.WriteLine("Invalid param");
            }
    }

    if (command.StartsWith("mkdir")) //создание файла/папки
    {
        var param = command.Split(' ')[1];
        var newName = command.Split(' ')[2];
        var fullNewPath = Path.Join(path, newName);

        if (param == "-d")
        {
            if (!Directory.Exists(fullNewPath))
            {
                Directory.CreateDirectory(fullNewPath); ///!!!!!!!!!!!!!!
                Console.WriteLine("directory created");
            }
        }
        else if (param == "-f")
        {
            if (!File.Exists(fullNewPath))
            {
                File.Create(fullNewPath).Dispose();
                Console.WriteLine("file created");
            }
        }
        else
        {
            Console.WriteLine("Invalid param");
        }
    }

    if (command == "exit")
    {
        return;
    }
}

static void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
{
    var dir = new DirectoryInfo(sourceDir);

    if (!dir.Exists)
    {
        throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");
    }

    DirectoryInfo[] dirs = dir.GetDirectories();
    Directory.CreateDirectory(destinationDir);

    foreach (FileInfo file in dir.GetFiles())
    {
        string targetFilePath = Path.Combine(destinationDir, file.Name);
        file.CopyTo(targetFilePath);
    }

    if (recursive)
    {
        foreach (DirectoryInfo subDir in dirs)
        {
            string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
            CopyDirectory(subDir.FullName, newDestinationDir, true);
        }
    }
}
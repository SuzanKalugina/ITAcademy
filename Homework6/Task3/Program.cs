 var str = "c:\\WebServers\\home\\testsite\\www\\myfile.txt";
 var indexExtension = str.LastIndexOf("\\");
 var indexExtension1 = str.LastIndexOf(".");
 var newStr = str.Substring(indexExtension + 1, indexExtension1 - indexExtension - 1);
 Console.WriteLine($"Имя файла: {newStr}");
 Console.WriteLine($"Второй способ: {Path.GetFileNameWithoutExtension(str)}");
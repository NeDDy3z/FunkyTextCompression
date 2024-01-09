# FunkyTextCompression

## Installation

- Extract the zip file **FunkyTextCompressionBuild.zip**
- Run the **alfadva.exe**
	- Execution via CMD: **alfadva.exe *{inputfile}.txt {outputfile}.txt***
- You can also edit **alfadva.dll.config** for faster use
  ```xml
    <appSettings>
        <add key="InputFile" value="{Your input file}.txt" />
        <add key="OutputFile" value="{Your output file}.txt" />
    </appSettings>
    ```

## Usage
The program will compress any Czech text by removing vowels, the text will look a bit weird and may seem unreadable, however, in Czech language the text will be the same and the compression wont alter its meaning.

After execution you'll be met with the following menu:

```
[ Menu ]
[1] Load data from .config file
[2] Load data from arguments
[3] Enter custom data
[4] Print out log
[5] Help
[0] Exit
```

- Press **0 - 5** to select an option
	- **1** load input and output files from the *alfadva.dll.config* file
	- **2** load arguments (paths) from CMD arguments
	- **3** enter input and output file
	- **4** print data from *Log/Log.txt* file
	- **5** basic tutorial
	- **0** Exit the program

When selected the option **1-3** and entering the data the confirmation prompt will be displayed:
After pressing any key, the compression will begin.

```
InputText.txt (2,843 KB)  >>>  OutputText.txt
Press any key to start compression...
```

When the compression finishes the program will display file details, here you can exit the program.

```
Compression has finished!
-------------------------
File: InputText.txt
Length: 2640 chrs
Size: 2,843 KB

File: OutputText.txt
Length: 1967 chrs
Size: 2,183 KB
-------------------------
Press any key to exit...
```

## License

Střední průmyslová škola elektrotechnická, Ječná 30 Praha 2, 120 00

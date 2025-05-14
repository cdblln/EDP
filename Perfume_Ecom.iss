[Setup]
AppName=Perfume Ecommerce
AppVersion=1.0
DefaultDirName={pf}\PerfumeEcommerce
DefaultGroupName=PerfumeEcommerce
OutputDir=C:\Users\CD\source\repos\cdblln\EDP\
OutputBaseFilename=PerfumeEcommerceInstaller
Compression=lzma
SolidCompression=yes

[Dirs]
Name: "{app}"; 

[Files]
; Main EXE
Source: "C:\Users\CD\source\repos\cdblln\EDP\Perfume_Ecommerce\bin\Debug\EDP.exe"; DestDir: "{app}"; Flags: ignoreversion

; All DLLs
Source: "C:\Users\CD\source\repos\cdblln\EDP\Perfume_Ecommerce\bin\Debug\*.dll"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs

; SQL file
Source: "C:\Users\CD\source\repos\cdblln\EDP\Perfume_Ecommerce\perfume_ecommerce_Database.sql"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
; Shortcut to the EXE
Name: "{group}\Perfume Ecommerce"; Filename: "{app}\EDP.exe"

; Optional desktop shortcut
Name: "{commondesktop}\Perfume Ecommerce"; Filename: "{app}\EDP.exe"; Tasks: desktopicon

[Tasks]
Name: "desktopicon"; Description: "Create a &desktop shortcut"; GroupDescription: "Additional icons:"

[Run]
; Run the correct EXE (EDP.exe) after installation
Filename: "{app}\EDP.exe"; Flags: nowait postinstall skipifsilent

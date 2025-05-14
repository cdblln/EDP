[Setup]
AppName=Perfume Ecommerce
AppVersion=1.0
DefaultDirName={pf}\PerfumeEcommerce
DefaultGroupName=Perfume Ecommerce
OutputDir=.
OutputBaseFilename=PerfumeInstaller
Compression=lzma
SolidCompression=yes

[Files]
; Main executable
Source: "C:\Users\CD\source\repos\cdblln\EDP\Perfume_Ecommerce\bin\Debug\EDP.exe"; DestDir: "{app}"; Flags: ignoreversion

; DLL dependencies (you may include more if your app needs them)
Source: "C:\Users\CD\source\repos\cdblln\EDP\Perfume_Ecommerce\bin\Debug\MySql.Data.dll"; DestDir: "{app}"; Flags: ignoreversion

; Your exported SQL file
Source: "C:\Users\CD\source\repos\cdblln\EDP\Perfume_Ecommerce\perfume_ecommerce_Database.sql"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\Perfume Ecommerce"; Filename: "{app}\Perfume_Ecommerce.exe"
Name: "{group}\Uninstall Perfume Ecommerce"; Filename: "{uninstallexe}"

[Run]
Filename: "{app}\Perfume_Ecommerce.exe"; Description: "Launch Perfume Ecommerce"; Flags: nowait postinstall skipifsilent

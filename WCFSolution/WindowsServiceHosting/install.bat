%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\installutil.exe WindowsServiceHosting.exe
Net Start WCFTestHosting
sc config WCFTestHosting start= auto
pause
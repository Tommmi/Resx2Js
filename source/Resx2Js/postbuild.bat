::

:: %1: project dir
:: %2: debug release
:: %3: Resx2Js.exe

::**********************************************************
:: copy output to ..\..\lib
::**********************************************************
del "%1..\..\lib\*.*" /f /q /s
copy "%1bin\%2\%3" "%1..\..\lib\%3"
copy "%1..\external\TUtils.Common\TUtils.Common.dll" "%1..\..\lib\TUtils.Common.dll"

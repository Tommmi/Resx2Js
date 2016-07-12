# Resx2Js
`Resx2Js.exe` is a console application which creates JavaScript files from VisualStudio resource files (*.resx).

Transpiles a VisualStudio resource file (*.resx) and it's depending locale translations (*.{loacale}.resx) into 
JavaScript files. Moreover it generates a CSharp file, which can be included into Saltarelle or Bridge.NET projects
to access the JavaScript-resources easily from CSharp code.

## History
see [history](Documentation/history.md)

## Example
Guess there are following files:
```
C:\MyTranslations\resource1.resx
C:\MyTranslations\resource1.de.resx
C:\MyTranslations\resource1.es.resx
```

Calling 
	resx2js.exe resxFilePath="C:\MyTranslations\resource1.resx" namespaceJs=MyNamespace transpiler=Saltarelle
will generate following files:
	C:\MyTranslations\resource1.js
	C:\MyTranslations\resource1.de.js
	C:\MyTranslations\resource1.es.js
	and
	C:\MyTranslations\resource1.cs

## USAGE
```
resx2js.exe
	resxFilePath="{file path to default resource}"
	namespaceJs={namespace used in generated files}
	transpiler=<Saltarelle|BridgeNet>
```

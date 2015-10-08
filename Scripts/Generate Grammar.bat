@ECHO OFF

ECHO.
ECHO ------------------------------------------
ECHO Regenerating Grammar with ANTLR 3.0
ECHO ------------------------------------------
ECHO.

cd ..\Src\Languages\Tiger\Tiger.Build\Compiler\Parser\
"..\..\..\..\..\..\3rd party\Tools\Antlr\Antlr3.exe" Tiger.g

ECHO.
ECHO ------------------------------------------
ECHO Grammar generated succefully
ECHO ------------------------------------------
ECHO.

PAUSE
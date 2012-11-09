@echo off

set MODULE=[MODULE-LC:Custom]
set PRODUCT=argos-%MODULE%

echo.
echo *** Setup and Build utility for %PRODUCT% ***
echo.

if not exist products\%PRODUCT% (
    echo.
    echo ******* ERROR *******
    echo "products\%PRODUCT%" does not exist.
    echo This utility should be run from the gobiplatform root,
    echo where \gobi-sdk and \products are subdirectories.
    echo.
    goto :EOF
)

echo *******************************
echo Building Product: %MODULE%
echo *******************************

pushd products\%PRODUCT%
call build\release.cmd
if %errorlevel% neq 0 ( 
	popd
	exit /b %errorlevel%
)
popd

if not exist deploy\%PRODUCT% (
	mkdir deploy\%PRODUCT%
)

echo *******************************
echo Deploying Product: %MODULE%
echo *******************************

if exist deploy\%PRODUCT% (
	rmdir deploy\%PRODUCT% /S /Q
)

mkdir deploy\%PRODUCT%

xcopy products\%PRODUCT%\deploy\*.* deploy\%PRODUCT% /E /Y /Q

:END
echo *******************************
echo Done
echo *******************************

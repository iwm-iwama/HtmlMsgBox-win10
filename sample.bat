@echo off
cls

for /f "usebackq delims=" %%s in (`"iwm_HtmlMsgBox.exe"`) do echo %%s

for /f "usebackq delims=" %%s in (`"iwm_HtmlMsgBox.exe -size=600,800 -title="�^�C�g��" -text="����������\\n����\\t������" -textsize=10 -checkbox="��L���e���������܂��B" -button=1,1 -buttontext="�͂�","������","����""`) do echo %%s

echo.
pause
exit

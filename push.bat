@echo off
git init
git add .
git commit -m "Auto-Push from script. (%DATE%%TIME%)"
git push -u origin master
echo:
echo:
echo:
echo:
echo:
echo DONE
echo:
echo:
echo:
echo:
echo:
pause
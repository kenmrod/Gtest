SET p=%1
net share /d GATE /y
net share GATE=%p% /UNLIMITED /GRANT:EVERYONE,FULL
exit
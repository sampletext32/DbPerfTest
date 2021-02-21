echo on
set bombardier="C:\Users\Admin\Downloads\bombardier.exe"
set url="localhost:5001/msperf/selectall"
%bombardier% %url% --method=GET -n 10000
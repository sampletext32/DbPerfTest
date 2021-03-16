echo on
set bombardier="C:\Users\Admin\Downloads\bombardier.exe"
set url="https://localhost:5001/postgresperf/selectall"
%bombardier% %url% --method=GET -n 10000
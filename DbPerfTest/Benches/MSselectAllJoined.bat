echo on
set bombardier="C:\Users\Admin\Downloads\bombardier.exe"
set url="https://localhost:5001/msperf/selectalljoined"
%bombardier% %url% --method=GET -n 10000
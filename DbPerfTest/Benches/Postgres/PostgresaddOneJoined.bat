echo on
set bombardier="C:\Users\Admin\Downloads\bombardier.exe"
set url="https://localhost:5001/postgresperf/addone"
set bodyfile="../dataoneJoined.json"
set header="Content-Type: application/json;charset=utf-8"
%bombardier% %url% --body-file=%bodyfile% --header=%header% --method=PUT -n 10000 --print=i,p,r
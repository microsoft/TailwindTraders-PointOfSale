sleep 15s
/opt/mssql-tools/bin/sqlcmd -S . -U sa -P Password1$ \
-Q "CREATE DATABASE [POS] ON (FILENAME ='/posdb/POS.mdf'),(FILENAME = '/posdb/POS_log.ldf') FOR ATTACH"

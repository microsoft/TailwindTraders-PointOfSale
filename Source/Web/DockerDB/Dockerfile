FROM mcr.microsoft.com/mssql/server:2017-latest

	ENV ACCEPT_EULA=Y
	ENV SA_PASSWORD=Password1$
	ENV MSSQL_TCP_PORT=1433
	EXPOSE 1433
	
	WORKDIR /src
        COPY attach_db.sh /posdb/
	COPY POS.mdf /posdb/
	COPY POS_log.ldf /posdb/
	RUN chmod +x /posdb/attach_db.sh
	RUN (/opt/mssql/bin/sqlservr --accept-eula & ) | grep -q "Service Broker manager has started" 
        ENTRYPOINT /posdb/attach_db.sh & /opt/mssql/bin/sqlservr

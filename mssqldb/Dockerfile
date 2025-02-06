FROM mcr.microsoft.com/mssql/server:2022-latest

USER root
RUN mkdir -p /opt/scripts
COPY init.sql /opt/scripts

ARG MSSQL_PASSWORD
ENV MSSQL_SA_PASSWORD=${MSSQL_PASSWORD}
ENV ACCEPT_EULA=Y

# optional: seed database with schema defined in ./init.sql
# RUN /opt/mssql/bin/sqlservr & sleep 60; /opt/mssql-tools18/bin/sqlcmd -C -S localhost -U sa -P ${MSSQL_PASSWORD} -d master -i /opt/scripts/init.sql
#!/usr/bin/env bash

dbserver="${DB_HOSTNAME}"
if [ -z "$dbserver" ]; then 
    dbserver="dbserver"
fi

echo "execute"
until nc -z $dbserver 5432; do
    echo "$(date) - waiting for $dbserver..."
    sleep 1
done

dotnet PortableWebApp.dll
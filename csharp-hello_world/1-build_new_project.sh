#!/usr/bin/env bash

if[-d "1-new_proyect"]; then
    mkdir -p 1-new_project && cd 1-new_project && dotnet new console && dotnet build
fi

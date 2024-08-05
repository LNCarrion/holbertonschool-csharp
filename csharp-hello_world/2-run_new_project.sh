#!/usr/bin/env bash

# Check if the directory 2-new_project exists
if [ ! -d "2-new_project" ]; then
    # Create a new console project named 2-new_project
    dotnet new console -n 2-new_project
fi

# Change the directory to 2-new_project
cd 2-new_project

# Build the project
dotnet build

# Run the project
dotnet run

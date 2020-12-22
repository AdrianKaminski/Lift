#!/bin/bash
projects=(Lift.Tests Lift.Tests.EndToEnd)
for project in ${projects[*]}
do
  echo Running tests for: $project
  dotnet test $project/$project.csproj
done

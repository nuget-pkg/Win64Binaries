#! /usr/bin/env bash
set -uvx
set -e
cd "$(dirname "$0")"
cwd=`pwd`
ts=`date "+%Y.%m%d.%H%M.%S"`
dotnet run --project Win64Binaries.Demo/Win64Binaries.Demo.csproj --framework net462 "$@"

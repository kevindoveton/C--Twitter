publish:
	dotnet publish -r osx.10.10-x64

run:
	./CSharp-React-Twitter/bin/Debug/netcoreapp2.0/osx.10.10-x64/CSharp-React-Twitter

client:
	cd react-client && npm run start

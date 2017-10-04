FROM microsoft/aspnetcore:2.0
ARG source
WORKDIR /app
EXPOSE 443:443
COPY ${source:-obj/Docker/publish} .
ENTRYPOINT ["dotnet", "Eshop.Web.dll"]

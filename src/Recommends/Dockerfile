FROM microsoft/dotnet:1.1-sdk-projectjson

COPY . /app 
WORKDIR /app
 
RUN ["dotnet", "restore"]
  
 
ENV ASPNETCORE_URLS http://+:80
EXPOSE 80
 
ENTRYPOINT ["dotnet", "run"]
FROM  mcr.microsoft.com/dotnet/core/sdk:2.2 as build-env
# code目录
WORKDIR /code  

#项目拷贝至code
COPY *.csproj ./ 
RUN dotnet restore

# #代码拷贝至code
COPY  . ./
# #发布文件在code/out文件夹
RUN dotnet publish -c Release -o out
# #找到runtime 
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
# #新建一个目录app
WORKDIR /app
# #code目录发布的代码文件放到app
COPY --from=build-env /code/out ./
# 输出到80端口
EXPOSE 80
ENTRYPOINT [ "dotnet","UserApi.dll" ]
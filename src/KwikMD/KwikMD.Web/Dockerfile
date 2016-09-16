FROM microsoft/dotnet
COPY . /app
# Set the Working Directory
WORKDIR /app

RUN ["dotnet", "restore"]


# Configure the listening port to 80
ENV ASPNETCORE_URLS http://*:80
EXPOSE 80

# Copy the app


# Start the app
ENTRYPOINT ["dotnet", "run"]

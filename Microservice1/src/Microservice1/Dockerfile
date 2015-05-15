FROM microsoft/aspnet

ADD . /app
WORKDIR /app

RUN dnu restore

EXPOSE 5000

ENTRYPOINT dnx . kestrel
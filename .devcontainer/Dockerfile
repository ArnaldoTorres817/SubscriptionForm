FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine

ARG USERNAME=dotnet

# Create the user
RUN adduser -g "" -D $USERNAME \
  && adduser $USERNAME wheel \
  && apk update \
  && apk upgrade \
  && apk add -u doas \
  && mkdir -p /etc/doas.d \
  && echo 'permit nopass :wheel' >> /etc/doas.d/doas.conf

RUN apk add --no-cache zsh curl git

USER $USERNAME

#!/bin/zsh

doas apk update
doas apk upgrade

export ZSH_THEME="cloud"

# oh my zsh
sh -c "$(curl -fsSL https://raw.github.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"

echo 'export PATH=$HOME/.local/bin:$PATH' >> ~/.zshrc

exit 0
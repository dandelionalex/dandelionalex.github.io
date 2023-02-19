## Cocoapods Issue on mac


iOS resolver can't install cocoapods and throu error like this:
https://stackoverflow.com/questions/72531306/unity-build-ios-framework-addition-failed-due-to-a-cocoapods-installation-failur

The problem is that installation of cocoapods requared new Ruby but by default 2.6 version installed
default version: 2.6.8p205
last version:  ruby 3.2.0

I install new version of ruby using this article:
https://mac.install.guide/ruby/13.html

https://mac.install.guide/ruby/9.html#

after that create 3 files and fill them with this data:

    
if [ -d "/opt/homebrew/opt/ruby/bin" ]; then
  export PATH=/opt/homebrew/opt/ruby/bin:$PATH
  export PATH=`gem environment gemdir`/bin:$PATH
fi

~/.zshrc
~/.profile
~/.bash_profile

/opt/homebrew/bin/ruby





# Add RVM to PATH for scripting. Make sure this is the last PATH variable change.
export PATH="$PATH:$HOME/.rvm/bin"

[[ -s "$HOME/.rvm/scripts/rvm" ]] && source "$HOME/.rvm/scripts/rvm" # Load RVM into a shell session *as a function*


export PATH="/usr/local/opt/ruby/bin:$PATH"
export LDFLAGS="-L/usr/local/opt/ruby/lib"
export CPPFLAGS="-I/usr/local/opt/ruby/include"
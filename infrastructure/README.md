To test this out:
=================

Bamboo server
-------------

Install the [Chef Client Installer for Windows](http://www.opscode.com/chef/install.msi)

1. Open a Command Prompt via "Run as administrator"
2. cd chef-repo dir
3. chef-solo -c nodes\chef-solo.rb -j nodes\ci-server.json
4. Open a browser to: [http://localhost:8085](http://localhost:8085)

# Refer to the Bamboo Windows Installation Guide:
# https://confluence.atlassian.com/display/BAMBOO/Bamboo+installation+guide+for+Windows

directory "#{node[:bamboo][:root]}" do
  action :create
end

windows_zipfile "#{node[:bamboo][:root]}" do
  source "http://www.atlassian.com/software/bamboo/downloads/binary/atlassian-bamboo-4.2.1.zip"
  action :unzip
  not_if {::File.exists?("#{node[:bamboo][:home]}/BambooConsole.bat")}
end

template "#{node[:bamboo][:home]}/webapp/WEB-INF/classes/bamboo-init.properties" do
  source "bamboo-init.properties.erb"
  inherits true
  variables(
    :bamboo_home_dir => node[:bamboo][:home],
    :bamboo_jms_broker_uri => node[:bamboo][:jms_broker_uri]
  )
end

windows_batch "Install Bamboo as a service" do
  code <<-EOH
    InstallAsService.bat
  EOH
  cwd node[:bamboo][:home]
  only_if { !`sc query bamboo | grep "service does not exist"`.empty? }
end

windows_batch "Start Bamboo service" do
  code <<-EOH
    StartBamboo.bat
  EOH
  cwd node[:bamboo][:home]
  only_if { `sc query bamboo | grep "RUNNING"`.empty? }
end

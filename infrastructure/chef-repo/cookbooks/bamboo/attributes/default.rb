default[:bamboo][:root] = "C:/Software"
default[:bamboo][:home] = "#{default[:bamboo][:root]}/Bamboo"
default[:bamboo][:jms_broker_uri] = "tcp://#{node[:fqdn]}:54663"

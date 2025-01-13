#!/bin/bash
sudo su
apt-get -y update                      # Update packages
apt-get -y install nginx               # Install Nginx
echo "<h1>Hello World from $(hostname)</h1>" > /var/www/html/index.html
systemctl restart nginx                # Restart Nginx to apply changes

//////////////////////////////////////////////////////////////////////////////
ssh para que funcione

sudo mkdir /var/www/html/video
sudo sh -c 'echo "Esto son mis videos/imagenes" > /var/www/html/video/index.html

luego vas y das la direccion ip seria
ip/video o imagenes // deberia mostrarte la pagina

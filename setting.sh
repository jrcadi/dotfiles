#sudo sed -i.bak -e "s%http://[^ ]\+%http://ftp.iij.ad.jp/pub/linux/ubuntu/archive/%g" /etc/apt/sources.list
# sudo sed -i.bak -e "s%http://[^ ]\+%http://ftp.jaist.ac.jp/pub/Linux/ubuntu/%g" /etc/apt/sources.list
cp .bash_aliases ~
cp .vimrc ~
cp .inputrc ~
cp .gitconfig ~
cd
sudo apt update
sudo apt install vim xinput hardinfo git guake

#デュアルブート時の時刻ズレ修正
sudo hwclock -D --systohc --localtime

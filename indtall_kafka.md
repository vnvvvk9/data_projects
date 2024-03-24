
1. install java

brew install java

java -version

echo 'export PATH="/opt/homebrew/opt/openjdk/bin:$PATH"' >> ~/.zshrc
 echo $PATH   
echo "${PATH//:/\n}"    

2. download kafka
https://kafka.apache.org/downloads


3. start zoppkeeper(change version): ~/kafka_2.13-3.0.0/bin/zookeeper-server-start.sh ~/kafka_2.13-3.0.0/config/zookeeper.properties

4. start Kafka
~/kafka_2.13-3.0.0/bin/kafka-server-start.sh ~/kafka_2.13-3.0.0/config/server.properties

PATH="$PATH:/Users/stephanemaarek/kafka_2.13-3.0.0/bin"


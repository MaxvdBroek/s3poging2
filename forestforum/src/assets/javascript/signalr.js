import { HubConnectionBuilder } from "@microsoft/signalr";

let connection;

export class CounterHub {
    constructor(){
        console.log("in hub")
        this.connection = new HubConnectionBuilder().withUrl("https://localhost:44376/counter").build();
        this.connection.onclose(async() =>{
            await this.connect();
        })

        this.connect();

        this.connection.on("updateCount", (count)=>{
            localStorage.setItem("count", count)
            window.dispatchEvent(counter)
        })
        
        
        const counter = new Event("count")
        
 
    }

  



    async connect(){
        try{
            await this.connection.start();
            console.log("SignalR Connected Succesfully")
        }
        catch(error){
            console.log(error)
        }
    }

    

}
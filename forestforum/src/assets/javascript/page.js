import axios from "axios";
import APIcalls from "./APIcalls";



export const Create = async(title,information,categoryID) =>{
await axios.post('https://localhost:44322/api/Page',{
Title: title,
Information: information,
CategoryID: categoryID

})

}


export const GetAllPages = async function(){
    try{
        await APIcalls.GetAllPages()
        .then(response =>{this.pageList = response.data})
    }
    catch(error){
        console.log(error)
    }
    return(this.pageList)
}


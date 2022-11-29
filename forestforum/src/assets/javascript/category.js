import APIcalls from "./APIcalls"

export const GetAllCategories = async function(){
    try{
        await APIcalls.GetAllCategories()
        .then(response =>{this.categoryList = response.data})
    }
    catch(error){
        console.log(error)
    }
}




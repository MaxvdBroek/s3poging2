import API from "./API";

export default{

    async GetAllCategories(){
        return await API().get('/Category/all')
    },
    async GetAllPagesFromCategory(){
        return await API().get('/Category/GetAllPagesFromCategory')
    },
    async GetAllPages(){
        return await API().get('/Page/all')
    },
}
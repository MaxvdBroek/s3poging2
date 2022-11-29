import axios from "axios";

export default(url='https://localhost:44322/api') => {
    return axios.create({
        baseURL : url,
    })
}
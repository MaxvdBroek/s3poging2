import { ref } from 'vue';
import axios from 'axios';

export const useFetch = (url, store) => {
  const data = ref(null);

  const fetchData = async () => {
    await axios.get('https://localhost:44322/api' + url).then(
      response => (data.value = response.data)
    )

    if(store)
    {
      localStorage.setItem(store,JSON.stringify(data.value));
    }
  }

  fetchData();

  return data;
}

export const useCache = (url, store) => {
  let data = ref(null);

  const fetchCache = () => {
    if(localStorage.getItem(store) !== null){
      data.value = JSON.parse(localStorage.getItem(store));
    }
    else{
      data = useFetch(url, store);
    }
  }

  fetchCache();

  return data;
}
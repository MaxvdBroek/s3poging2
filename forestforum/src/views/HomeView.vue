<script setup>
import Information from '@/components/Homescreen.vue'
import Axiostest from '@/components/AxiosTest.vue'
import {CounterHub} from '../assets/javascript/signalr'

</script>

<template>
  <information/>
  <axiostest/>
  <h4 v-if="(counter >= 1)">Current users:{{counter}}</h4>
</template>

<script>

export default {
  name: 'HomeView',
  components: { Information, Axiostest

  },
  data(){
    return{
      counter: null
    }
  },
  mounted(){
  this.counter = new CounterHub()
  window.addEventListener("count", ()=>{
    this.counter = localStorage.getItem("count")
  })
  }

}
</script>
<style >

</style>
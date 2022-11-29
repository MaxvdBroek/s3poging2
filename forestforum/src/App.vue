<template>
  <navbar/>
  
  <router-view :key="$route.path"/>
</template>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

</style>

<script>
import navbar from '@/components/Navbar.vue'


export default {
  name: 'App',
  components: {
    navbar
  }
}

</script>


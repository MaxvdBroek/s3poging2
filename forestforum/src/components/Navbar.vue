<script setup>
import { GetAllCategories } from "@/assets/javascript/category"
import { GetAllPages} from "@/assets/javascript/page"
import { RouterLink } from "vue-router";


</script>


<template>
<nav class="navbar fixed-top navbar-expand-lg bg-dark">
  <div class="container-fluid">
    <a class="navbar-brand color" href="#">Forest Forum</a>
    <button class="navbar-toggler color" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon color"></span>
    </button>
    <div class="collapse navbar-collapse color" id="navbarNavAltMarkup">
      <div class="navbar-nav">
        <router-link to="/" class="nav-link active color" aria-current="page">Home</router-link>
        <router-link to="/about" class="nav-link active color" aria-current="page">About</router-link>
        <li v-for="category in categoryList" :key="category.id">
        <div class="collapse navbar-collapse" id="navbarNavDarkDropdown">
        <ul class="navbar-nav color">
          <li class="nav-item dropdown">
            <a class="nav-link dropdown-toggle color" href="#" id="navbarDarkDropdownMenuLink" role="button" data-bs-toggle="dropdown" aria-expanded="false">
            {{category.categoryName}}
            </a>
            <ul class="dropdown-menu dropdown-menu-dark" aria-labelledby="navbarDarkDropdownMenuLink">
              
              <div v-for="page in pageList" :key="page.id">
              <li v-if="page.categoryID == category.categoryID"><RouterLink class="dropdown-item" :to="{path:'/Page/' + page.pageID}">{{page.title}}</RouterLink ></li>
              </div>
            </ul>

          </li>
        </ul>
    </div>
    </li>
        
      </div>
    
    </div>
  </div>
</nav>
</template>

<script>
export default {
    data() {
        return {
            categoryList: [],
            pageList: [],
        };
    },
    mounted() {
        this.GetAllCategories(),
            this.GetAllPages();
    },
    components: { RouterLink }
}
</script>

<style>
.color{
    color: rgb(196, 192, 192) !important;
    
    
}
.dropdown-menu {
    max-height: 280px;
    overflow-y: auto;
}



</style>
<script setup>
import {Create} from '../assets/javascript/page'
import { GetAllCategories } from "@/assets/javascript/category"

</script>
<template>
  <form @submit.prevent="submit">
    <div class="test">
      <label for="title">title</label><br>
      <input class="form-control" id="title" type="text" v-model="title" required/>
    </div>
    <div class="test">
      <label for="information">Information</label><br>
      <textarea class="form-control" id="information" rows="3" v-model="information" required></textarea>
    </div>
    <div class="test">
      <label for="Category">Category</label><br>
      <div v-if="categoryList != null">
      <select  id="cat" class="form-select test" aria-label="Default select example" v-model="categoryID"  required>
        <option value="" disabled selected>Select your option</option>
        <option v-for="category in categoryList" :key="category.id" :value=category.categoryID>{{category.categoryName}}</option>



      </select>
      </div>
    </div>
    <br>
    <button type="submit"  class="btn btn-primary btn-sm"><meta http-equiv="refresh">Submit</button>
  </form>
</template>

<script>


export default {
data(){
    return{
      categoryList:[],
        title:'',
        information:'',
        categoryID:''
    }
},
methods:{
    submit(){
        Create(this.title,this.information,this.categoryID)
    },

},
mounted(){
  this.GetAllCategories()
    }
}
</script>

<style>
.test{
  width: 25%;
  margin: auto;
}
</style>
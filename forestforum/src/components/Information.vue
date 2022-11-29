<script setup >
import { useRoute } from 'vue-router'

import API from '@/assets/javascript/API.js'
import { ref } from 'vue';
const route = useRoute();
const page = ref();
 API().get('Page/id?id=' + route.params.id).then(result => page.value = result);
console.log(page)

defineProps({
    Title: {
      type: String,
      required: true,
      default: "Lorem",
    }
})

</script>

<template>
<h1 v-if="page != null" class="test1">{{page.data.title}}</h1>
<h1 v-if="page != null" class="">{{page.data.information}}</h1>
</template>

<style>
h1{
    margin-top: 100px;
}
.test1{
    margin-top: 100px !important;
}
</style>
<template>
<div class="card background text-white margins">
  <img class="card-img cropped1 content" src="@/assets/images/forestbanner.png" alt="Card image">
  <div class="card-img-overlay">
    <h5 class="card-title text">WELKOM BIJ</h5>
    <h1 class="text size">The Forest wiki</h1>
    <p class="card-text test">het meest verkrachte kut forum wat je op het gehele internet gaat vinden</p>
  </div>
</div>

</template>

<script>
export default {
         
}
</script>

<style scoped>
.cropped1 {
    width: 1000px; /* width of container */
    height: 200px; /* height of container */
    object-fit: cover;
    margin: auto;


}
.margins{
    margin: auto;
    margin-top: 100px;
}
.text{
    
    color: #e5c500 !important;
    font-weight: bold;
    font-size: 30px;
}
.test{
    
    margin: auto; 
    text-align: center;
    color: #e5c500 !important;

}
.background{
    background-color: #858282;
    border: none;
}
.size{
    font-size: 40px;
}



.content {
    width: 90%; /* or whatever is required */
    text-align: center; /* ensures the image is always in the h-middle */
    overflow: hidden; /* hide the cropped portion */
}

</style>
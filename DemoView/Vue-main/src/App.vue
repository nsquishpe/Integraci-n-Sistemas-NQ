<template>

  <HeaderItem title="VueCrud"/>
  <Router-view></Router-view>
</template>

<script>


import HeaderItem from './components/HeaderItem.vue';

export default {
  name: 'App',
  components: {
    HeaderItem,
   
}
}
</script>
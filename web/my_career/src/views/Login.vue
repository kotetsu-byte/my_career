<template>
    <div class="flex-div">
        <div id="left">
            <LoginComponent />
        </div>
        <div id="right">
            
        </div>
    </div>
</template>

<script>
import LoginComponent from '../components/LoginComponent.vue';

export default {
    name: 'Login',
    components: {LoginComponent},
    data() {
        return {
            email: '',
            password: '',
            confirmPassword: ''
        }
    },
    methods: {

    },
    computed: {

    },
    mounted() {

    }
}
</script>

<style scoped>
.flex-div {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
}

#left {
    width: 49%;
    background: url(../assets/img/logo.png) no-repeat;
    background-size: contain;
    height: 100vh;
}

#right {
    height: 100vh;
    width: 49%;
    background: url(../assets/img/templates.png) no-repeat;
    background-size: cover;
}
</style>
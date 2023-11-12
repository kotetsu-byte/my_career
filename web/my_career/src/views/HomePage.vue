<template>
    <div class="super-container">
        <div id="content">
            <div onclick="location.href = '/resume-type'" style="background-color: white;">
                <div class="flex-div" style="align-items: center; justify-content: start;">
                    <img src="../assets/icons/select/freelancer.png" alt="">
                    <span>New Resume</span>
                </div>
            </div>
            <br><br>
            <div onclick="location.href = '/my-resumes'" style="background-color: white;">
                <div class="flex-div" style="align-items: center; justify-content: start;">
                    <img src="../assets/icons/select/company.png" alt="">
                    <span>My Resumes</span>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    name: 'HomePage',
    components: {},
    data() {
        return {
            
        }
    },
    props: {

    },
    methods: {

    },
    watch: {

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
.super-container {
    padding-top: 200px;
    width: 100%;
    background: url(../assets/img/logo.png) no-repeat;
    height: 100vh;
}

#content {
    margin-top: 100px;
    margin-left: 100px;
    width: 400px;
}

#content > div {
    padding: 10px;
    background: white;
    border-radius: 15px;
}
</style>
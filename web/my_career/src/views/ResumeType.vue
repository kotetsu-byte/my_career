<template>
    <div class="flex-div">
        <div id="left">
            <div id="choice">
                <div onclick="location.href = '/freelance'">
                    <div class="flex-div" style="align-items: center; justify-content: start;">
                        <img src="../assets/icons/select/freelancer.png" style="margin-right: 10px;" alt="">
                        <span>Freelancer</span>
                    </div>
                </div>
                <br><br>
                <div onclick="location.href = '/company'">
                    <div class="flex-div" style="align-items: center; justify-content: start;">
                        <img src="../assets/icons/select/company.png" style="margin-right: 10px;" alt="">
                        <span>Company</span>
                    </div>
                </div>
            </div>
        </div>
        <div id="right">
            <button onclick="location.href = '/home'">&lt; Back</button><br>
            <img src="../assets/img/computer.png" width="550" alt="">
        </div>
    </div>
</template>

<script>
export default {
    name: 'ResumeType',
    components: {},
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
}

#choice {
    margin: 200px auto;
    width: 400px;
}

#choice > div {
    padding: 10px;
    background: white;
    border-radius: 15px;
    border: 1px solid black;
}
</style>
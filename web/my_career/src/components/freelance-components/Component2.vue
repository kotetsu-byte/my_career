<template>
    <div class="container">
        <p style="font-size: 30px; font-weight: 700; margin-bottom: 10px;">Welcome dilmurod</p>
        <p style="font-size: 18px; font-weight: 500; color: #323232; margin-bottom: 10px;">Complete your profile to join our global community of freelancers and start selling your services to our growing network of businesses.</p>
        <label for=""><span style="font-size: 18px; font-weight: 500; color: #323232;">Living address</span></label>
        <div class="flex-div" style="margin: 10px 0;">
            <div style="margin-right: 10px 0;">
                <input type="text" placeholder="Country*" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
            </div>
            <div>
                <input type="text" placeholder="Region*" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
            </div>
        </div>
        <input type="text" placeholder="Street, apartment" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 90%;"><br>
        <div style="text-align: right;">
            <button @click="prev(1)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Back</button>
            <button @click="next(3)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Next</button>
        </div>
    </div>
</template>

<script>
export default {
    name: 'Component2',
    components: {},
    props: {
        
    },
    data() {
        return {
            
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
.container {
    margin: 100px auto 0 auto;
    min-width: 400px;
    max-width: max-content;
    background-color: white;
    border-radius: 12px;
    padding: 20px;
    width: max-content;
    max-width: 500px;
}
</style>
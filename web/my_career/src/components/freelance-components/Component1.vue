<template>
    <div class="container">
        <div style="text-align: center; margin-bottom: 10px;">
            <img src="../../assets/icons/photo/photo.png" alt="">
            <p style="font-size: 18px; font-weight: 500; color: #808080;">Add your profile photo</p>
        </div>
        <div class="flex-div" style="margin: 10px 0;">
            <div style="margin-right: 10px;">
                <label><span style="font-size: 18px; font-weight: 500; color: #323232;">First name*</span></label><br>
                <input type="text" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
            </div>
            <div>
                <label><span style="font-size: 18px; font-weight: 500; color: #323232;">Last name*</span></label><br>
                <input type="text" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
            </div>
        </div>
        <div class="flex-div" style="margin: 5px 0;">
            <div style="margin-right: 10px;">
                <label><span style="font-size: 18px; font-weight: 500; color: #323232;">E-mail*</span></label><br>
                <input type="email" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
            </div>
            <div>
                <label><span style="font-size: 18px; font-weight: 500; color: #323232;">Phone number*</span></label><br>
                <input type="tel" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
            </div>    
        </div>
        <div style="text-align: right;">
            <button @click="next(2)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Next</button>    
        </div>
    </div>
</template>

<script>
export default {
    name: 'Component1',
    components: {},
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

.flex-div {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-items: center;
}

.grid-div {
    display: grid;
    grid-template-columns: 1fr 1fr 1fr;
}
</style>
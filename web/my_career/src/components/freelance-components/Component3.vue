<template>
    <div class="container">
        <p>Write a little about yourself</p>
        <div class="flex-div">
            <div style="margin-right: 10px 0;">
                <label for="">Write your position*</label><br>
                <input type="text" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
            </div>
            <div>
                <label for="">Date of birth*</label><br>
                <input type="date" name="" id="" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
            </div>
        </div>
        <label for="">Write down your skills*</label><br>
        <input type="text" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 90%;"><br>
        <label for="">Hobbies</label><br>
        <input type="text" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 90%;"><br>
        <textarea name="" id="" cols="30" rows="10" placeholder="Describe yourself to buyers" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 90%; height: 200px; resize: none;"></textarea>
        <div style="text-align: right;">
            <button @click="prev(2)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Back</button>
            <button @click="next(4)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Next</button>
        </div>
    </div>
</template>

<script>
export default {
    name: 'Component3',
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
<template>
<div class="container">
        <p>Write language you speak</p>
        <p>The more languages ​​you know, the more foreign employers will contact you.</p>
        <label for="">Language*</label>
        <div class="language">
            <div class="flex-div">
                <div style="margin-right: 10px 0;">
                    <input type="text" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
                </div>
                <div>
                    <input type="text" style="padding: 15px 20px; border-radius: 8px; border: 1px solid #CDCDCD; font-size: 20px; font-weight: 500; width: 80%;">
                </div>
            </div>
        </div>
        <button>+ Add new</button><br>
        <div style="text-align: right;">
            <button @click="prev(3)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Back</button>
            <button @click="next(5)" style="margin-top: 10px; background-color: white; border: 1px solid #1D71B8; padding: 10px 20px; border-radius: 8px; cursor: pointer;">Next</button>
        </div>
    </div>
</template>

<script>
export default {
    name: 'Component4',
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